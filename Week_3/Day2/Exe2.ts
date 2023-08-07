interface Person{
    firstName:string ,
    lastName: string,
    age: number
};

function introduce(person: Person){
    console.log(`${person.firstName} ${person.lastName} is ${person.age} years old`)
};

const person1: Person = {
    firstName: "Nirva",
    lastName: "Padaliya",
    age: 22
};

const person2: Person = {
    firstName: "newen",
    lastName: "newmsutfrd",
    age: 24
};

introduce(person1);
introduce(person2);