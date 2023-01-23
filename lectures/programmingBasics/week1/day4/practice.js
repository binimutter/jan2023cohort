var arr01 = ["Bear", "Abby", "Lucy", "Roxy","Copper"]
var arr02 = [1,2,3]
var arr03 = [-1, 3, 6,-6, 9, -24, 8, 6, -100, 5000]
var arr04 = [2,5,7,3,4,6,9]

// Create a function that can use any of the above arrays and prints each value

// function printArr (arr) {
//     for (let i = 0; i < arr.length; i++) {
//         console.log(arr[i])
//     }
// }

// Given 2 numbers create a function that adds, subtracts, multiplies, and divides them and pushes each result into an array.  Print the array of results

// function mathArr (num1, num2) {
//     var newArr = []
//     newArr.push(num1 + num2, num1 - num2, num1 * num2, num1 / num2)
//     console.log(newArr)
// }

// mathArr(10, 5)


// Create a function that takes any negative numbers and puts them in a new array and replaces that negative number with the word "negative", print both arrays

// function negativeArr (arr) {
//     var newArr = []
//     for (let i = 0; i < arr.length; i++) {
//         if (arr[i] < 0) {
//             newArr.push(arr[i])
//             arr[i] = 'negative'
//         }
//     }
//     console.log(arr)
//     console.log(newArr)
// }

// negativeArr(arr03)


// Create a function that replaces any even number with the word "even"

function even (arr) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 === 0) {
            arr[i] = "even"
        }
    }
    console.log(arr)
}

even(arr04)



