// print odd numbers 1-255

for(let i = 1; i <= 255; i += 2) {
    // console.log('odd numbers:', i)
}

for (let i = 1; i <= 255; i++) {
    if (i % 2 != 0) {
        // console.log('odd numbers:', i)
    }
}

// VAR

// can duplicate, function scoped
var name = "Ubin"
var name = "Yoob"

// LET

// CANNOT duplicate, but can be updated
var name = "Ubin"
name = "Yoob"

var hello = "Good Morning Jarell"

let sum = 0 // Global variable usable by any other function, loop, or condition

for (let i = 0; i < 200; i++) {
    if (i % 2 == 0) {
        sum = sum + i
    } else {
        sum = sum - 1
    }
    console.log('current value of i:', i, 'current sum', sum)
}
