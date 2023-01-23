// Predict 1
// function greeting(){
//         return "Hello";
//         console.log("World");
//     }
//     var word = greeting();
//     console.log(word);
    

// Predicted Output: 
// Hello
// World

// Actual Output:
// Hello

// Notes:
// The console log is after the return statement so the console.log("World") isn't being executed


// Predict 2
// function add(num1, num2){
//         console.log("Summing Numbers!");
//         console.log("num1 is: " + num1);
//         console.log("num2 is: " + num2);
//         var sum = num1 + num2;
//         return sum;
//     }
//     var result1 = add(3,5);
//     var result2 = add(4,7);
//     console.log(result1);
//     console.log(result2);
    

// Predicted Output: 
// Summing Numbers!
// num1 is 3
// num2 is 5
// 8
// Summing Numbers!
// num1 is 4
// num2 is 7
// 11

// Actual Output:
// Summing Numbers!
// num1 is: 3
// num2 is: 5
// Summing Numbers!
// num1 is: 4
// num2 is: 7
// 8
// 11

// Notes:
// It's running the function for result 1 and result 2 and storing the sum value for both but since the console.log for result 1 and 2 are executed after the function has run it is printed consecutively after the console logs in the function. Might need more clarification on this one.


// Predict 3
// function highFive(num){
//     for(var i=0; i<num; i++){
//         if(i == 5){
//             console.log("High Five!");
//         }
//         else{
//             console.log(i);
//         }
//     }
// }

// console.log(highFive(7))

// Predicted Output: 
// nothing because function is not called
// for example:
// 0
// 1
// 2
// 3
// 4
// High Five!
// 6

// Actual Output:
// 0
// 1
// 2
// 3
// 4
// High Five!
// 6
// undefined

// Notes:
// Function still runs for 7 beacuse for loop is inside the function? That's why it's printing undefined?