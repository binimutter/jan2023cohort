// Like we do in class break this down line by line then predict the outcome, and then run it to see if you were right

let arr01 = ["This is just a test", 2, 5, 7, "Just for practice"]
let arr02 = []
for(let i = 0; i < arr01.length; i++) {
    if(arr01[i] > 0) {
        arr02.push(arr01[i])
    } else {
        console.log("I seem to have failed the if check")
    }
}
console.log('updated arr01:', arr01)
console.log('updated arr02:', arr02)


// Return Odds Array 1-255 Create an array with all the odd integers between 1 and 255 (inclusive).

// for loop - start @ 1; stop <= 255; move through loop - i++
// conditional- 1 % 2 == 1 => if true empty array .push i
// empty array

let arr03 = []
for (let i = 0; i <= 255; i++) {
    if (i % 2 == 1) {
        arr03.push(i)
    }
}
console.log(arr03)

// Given the following array print each value
var arr04 = ["Arrays and loops", "can be fun", "but they can also", "be hard"]


// Add the following array to the above array at the end
var arr05 = [2,4,6,24,8,10]


// Print all of the value contained in the entire updated arr04 (hint you will need a conditional statement)


// Print the number 24 from the updated arr04