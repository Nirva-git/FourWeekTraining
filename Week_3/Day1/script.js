// Prompt the user for their name
function enterName(){
const userName = prompt("What is your name?");

// Check if the user entered a name
    if (userName) {
        // Display the greeting in an alert box
        alert(`Hello, ${userName}! Welcome!`);
    } else {
        // If the user didn't enter a name, display a generic greeting
        alert("Hello! Welcome!");
    }
}

function SumOfTwoNum(){
    const Num1 = parseInt(prompt("Enter is first number!"));
    const Num2 = parseInt(prompt("Enter is second number!"));

    const sum = Num1+Num2;
    if (sum) {
        
        alert(`Hello! Your sum is ${sum}!`);
    } else {
       
        alert(`Hello! enter numbers first!`);
    }
}

function myFunction(){
    alert("Button Clicked!!")
}

function fomSum(){
    const Num1 = parseInt(document.getElementById("fnum").value);
    const Num2 = parseInt(document.getElementById("snum").value);
    var sum = Num1+Num2;
    console.log(sum);
    document.getElementById("sumP").innerHTML = sum;    
}

function numOccurence(){
    const n = prompt("What is your size of array?");
    const numbers= [];
    const list= {};
    for(var i=0; i< n; i++){
        numbers[i]= prompt("Enter your number...")
    }
    for(var i=0; i< numbers.length; i++){
        if(list[numbers[i]]){
            list[numbers[i]]++;
        }
        else{
            list[numbers[i]]=1;
        }
    }
    document.getElementById("Arr").innerHTML= JSON.stringify(list);
}

function reversedString(){
    const inputString = prompt("Enter a string:");
    if (inputString === null) {
        alert("string not given!!")
    }
    else{
        const reversedString = inputString.split('').reverse().join('');
        alert(`${reversedString}`) ;
    }
}

function getUniqueNumbers(numbers) {
    const uniqueNumbers = [];

    numbers.forEach(number => {
        if (!uniqueNumbers.includes(number)) {
            uniqueNumbers.push(number);
        }
    });

    return uniqueNumbers;
}
function uniqueNumArry(){
    const numbersArray = [1, 2, 3, 2, 4, 1, 5, 6, 5];
    const uniqueNumbersArray = getUniqueNumbers(numbersArray);
    alert(uniqueNumbersArray); 
}

function getIntersectionNumbers(arr1, arr2) {
    const intersection = arr1.filter(number => arr2.includes(number));
    return intersection;
}
function intersectionNumArry(){
    const numbersArr1 = [1, 2, 3, 4, 5];
    const numbersArr2 = [3, 4, 5, 6, 7];
    const interNumbersArray = getIntersectionNumbers(numbersArr1, numbersArr2);
    alert(interNumbersArray); 
}

//Exe 7 Part1
    const student = {
        name: "John Doe",
        gradeLevel: "12th",
        courses: ["Math", "Science", "English"],
        addCourse(courseName) {
            if (!this.courses.includes(courseName)) {
                this.courses.push(courseName);
            }
        },
        removeCourse(courseName) {
            const index = this.courses.indexOf(courseName);
            if (index !== -1) {
                this.courses.splice(index, 1);
            }
        },
    };
    
    console.log(student.name); 
    console.log(student.gradeLevel); 
    console.log(student.courses); 
    
     student.addCourse("History");
     console.log(student.courses);
    student.removeCourse("Science");
     console.log(student.courses); 

//Exe7 part2

function studentsTakingCourse(studentsArray, courseName) {
    const studentsWithCourse = studentsArray.filter(student => student.courses.includes(courseName));
    return studentsWithCourse;
}

// Example usage:
const students = [
    {
        name: "John Doe",
        gradeLevel: "12th",
        courses: ["Math", "Science", "English"],
    },
    {
        name: "Jane Smith",
        gradeLevel: "11th",
        courses: ["Science", "History", "Spanish"],
    },
    {
        name: "Michael Johnson",
        gradeLevel: "10th",
        courses: ["Math", "English"],
    },
];

const courseNameToCheck = "Math";
const studentsTakingMath = studentsTakingCourse(students, courseNameToCheck);
console.log(studentsTakingMath);
                                                                        