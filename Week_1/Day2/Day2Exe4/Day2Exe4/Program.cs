namespace Day2Exe4
{
    internal class Program
    {
        public interface IVehicle
        {
            void Drive();
        }
        
        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Car is being driven.");
            }
        }
        public class Truck : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Truck is being driven.");
            }
        }
        
        public class VehicleLogger
        {
            private static VehicleLogger? instance;
            private VehicleLogger() {
                instance = new VehicleLogger();
            }
            public static VehicleLogger Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new VehicleLogger();
                    }
                    return instance;
                }
            }
            public void Log(string message)
            {
                Console.WriteLine("Logging: " + message);
            }
        }
        // 4. Implement Factory Method Pattern with VehicleFactory
        public abstract class VehicleFactory
        {
            public abstract IVehicle CreateVehicle();
            public void DoSomethingWithVehicle()
            {
                IVehicle vehicle = CreateVehicle();
                vehicle.Drive();
            }
        }
        // 5. Implement CarFactory and TruckFactory
        public class CarFactory : VehicleFactory
        {
            public override IVehicle CreateVehicle()
            {
                return new Car();
            }
        }
        public class TruckFactory : VehicleFactory
        {
            public override IVehicle CreateVehicle()
            {
                return new Truck();
            }
        }
        // 6. Implement IRepository<T> interface
        public interface IRepository<T>
        {
            T GetById(int id);
            IEnumerable<T> GetAll();
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }
        // 7. Implement VehicleRepository
        public class VehicleRepository : IRepository<IVehicle>
        {
            private List<IVehicle> vehicles;
            public VehicleRepository()
            {
                vehicles = new List<IVehicle>();
            }
            public IVehicle GetById(int id)
            {
                return vehicles.FirstOrDefault(vehicle => vehicle.GetHashCode() == id);
            }
            public IEnumerable<IVehicle> GetAll()
            {
                return vehicles;
            }
            public void Add(IVehicle entity)
            {
                vehicles.Add(entity);
            }
            public void Update(IVehicle entity)
            {
                // Implement update logic
            }
            public void Delete(IVehicle entity)
            {
                vehicles.Remove(entity);
            }
        }
        // 8. Implement VehicleService
        public class VehicleService
        {
            private IRepository<IVehicle> repository;
            private VehicleLogger logger;
            public VehicleService(IRepository<IVehicle> repository)
            {
                this.repository = repository;
                logger = VehicleLogger.Instance;
            }
            public void AddVehicle(VehicleFactory factory)
            {
                IVehicle vehicle = factory.CreateVehicle();
                repository.Add(vehicle);
                logger.Log("Vehicle added: " + vehicle.GetType().Name);
            }
            public void RemoveVehicle(int id)
            {
                IVehicle vehicle = repository.GetById(id);
                if (vehicle != null)
                {
                    repository.Delete(vehicle);
                    logger.Log("Vehicle removed: " + vehicle.GetType().Name);
                }
            }
            public void ListVehicles()
            {
                foreach (IVehicle vehicle in repository.GetAll())
                {
                    Console.WriteLine(vehicle.GetType().Name);
                }
            }
            public void DoSomethingWithVehicle(int id)
            {
                IVehicle vehicle = repository.GetById(id);
                if (vehicle != null)
                {
                    VehicleFactory factory;
                    if (vehicle is Car)
                    {
                        factory = new CarFactory();
                    }
                    else if (vehicle is Truck)
                    {
                        factory = new TruckFactory();
                    }
                    else
                    {
                        throw new NotSupportedException("Vehicle type not supported.");
                    }
                    factory.DoSomethingWithVehicle();
                }
            }
        }
        // 9. Use VehicleService in Main method
        public class Program
        {
            public static void Main(string[] args)
            {
                VehicleRepository repository = new VehicleRepository();
                VehicleService service = new VehicleService(repository);
                // Add vehicles
                service.AddVehicle(new CarFactory());
                service.AddVehicle(new TruckFactory());
                // List vehicles
                service.ListVehicles();
                // Do something with a vehicle
                service.DoSomethingWithVehicle(1);
                // Remove a vehicle
                service.RemoveVehicle(2);
                // List vehicles again
                service.ListVehicles();
            }
        }

    }
}