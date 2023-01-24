// Sigma - Implement function sigma(num) that, given a number, returns the sum of all positive integers up to the given number (inclusive).  Ex: sigma(3) = 6 (or 1+2+3); sigma(5) = 15 (or 1+2+3+4+5).

function sigma(num) {
    let result = 0
    for (let i = 0; i <= num; i++) {
        result += i
    }
    console.log(result)
    return result
}

sigma(5)

// Factorial - Write a function factorial(num) that, given a number, returns the product (multiplication) of all positive integers from 1 up to the given number (inclusive).  For example, factorial(3) = 6 (or 1*2*3); factorial(5) = 120 (or 1*2*3*4*5).

function factorial(num) {
    let result = 1
    for (let i = num; i > 0; i--) {
        result *= i
    }
    console.log(result)
    return result
}

factorial(5)

// Fibonacci - Create a function to generate Fibonacci numbers.  In this famous mathematical sequence, each number is the sum of the previous two, starting with values 0 and 1.  Your function should accept one argument, an index into the sequence (where 0 corresponds to the initial value, 4 corresponds to the value four later, etc).  Examples: fibonacci(0) = 0 (given), fibonacci(1) = 1 (given), fibonacci(2) = 1 (fib(0)+fib(1), or 0+1), fibonacci(3) = 2 (fib(1) + fib(2)3, or 1+1), fibonacci(4) = 3 (1+2), fibonacci(5) = 5 (2+3), fibonacci(6) = 8 (3+5), fibonacci(7) = 13 (5+8).  

function fibonacci(num) {
    if (num < 2) {
        return num;
    } else {
        return fibonacci(num -2) + fibonacci(num - 1)
    }
}

console.log(fibonacci(7))

// Array: Second-to-Last: Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.

function secondToLast(arr) {
    if (arr.length < 2) {
        return null
    }
    return arr[arr.length - 2]
}

console.log(secondToLast([42, true, 4, "Liam", 7]))

// Array: Nth-to-Last: Return the element that is N-from-array's-end.  Given ([5,2,3,6,4,9,7],3), return 4.  If the array is too short, return null.

function nthToLast(arr, num) {
    if (arr.length - num < 0) {
        return null
    }
    return arr[arr.length - num]
}

console.log(nthToLast([5,2,3,6,4,9,7], 3))
console.log(nthToLast([5,2,3,6,4,9,7], 7))
console.log(nthToLast([5,2,3,6,4,9,7], 9))
console.log(nthToLast([5,2,3,6,4,9,7], 5))

// Array: Second-Largest: Return the second-largest element of an array. Given [42,1,4,3.14,7], return 7.  If the array is too short, return null.

function secondLargest(arr) {
    if (arr.length < 2) {
        return null
    }
    let max = 0
    let second = 0
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > max) {
            second = max
            max = arr[i]
        } else if (arr[i] > second && arr[i] != max) {
            second = arr[i]
        }
    }
    console.log(second)
    return second
}

secondLargest([42,1,4,3.14,7])

// Double Trouble: Create a function that changes a given array to list each existing element twice, retaining original order.  Convert [4, "Ulysses", 42, false] to [4,4, "Ulysses", "Ulysses", 42, 42, false, false].

function doubleTrouble(arr) {
    // let element = 0
    // for (let i = 0; i < arr.length; i++) {
    //     element = arr[i]
    //     arr.splice((i + 1), 0, element)
    // }
    // console.log(arr)
    // return arr
    let i = arr.length //VERY IMPORTANT - ENDLESS LOOP IF ITS NOT THERE
    while (i--) {
        arr.splice(i, 0, arr[i])
    }
    console.log(arr)
    return arr
}

doubleTrouble([4, "Ulysses", 42, false])