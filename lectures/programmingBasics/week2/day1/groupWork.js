// Group Work

// Create a function that takes and array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]

function threeArrs(arr) {
    let even = []
    let negative = []
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 === 0) {
            even.push(arr[i])
            if (arr[i] < 0) {
                negative.push(arr[i])
            }
        } else if (arr[i] < 0) {
            negative.push(arr[i])
            arr[i] = "pop"
        }
    }
    console.log(arr)
    console.log(even)
    console.log(negative)
}

threeArrs(arr01)



// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]

function innerArrays(arr) {
    let totalSum = 0
    let totalCount = 0
    for (let i = 0; i < arr.length; i++) {
        let inner = arr[i]
        let max = 0
        let min = inner[0]
        let sum = 0
        for (let j = 0; j < inner.length; j++) {
            totalCount++
            sum += inner[j]
            if (inner[j] > max) {
                max = inner[j]
            } else if (inner[j] < min) {
                min = inner[j]
            }
        }
        console.log(`max: ${max}, min: ${min}, average: ${(sum / inner.length)}`)
        totalSum += sum

    }
    console.log(`total average: ${totalSum / totalCount}`)
}

innerArrays(arr02)


// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [{name: 'Bear', type: 'dog', stats: [{age: 7, color: ['brown', 'black']}]}, {name: 'Copper', type: 'dog', stats: [{age: 2, color: ['White', 'brown', 'black']}]}, {name: 'Lily', type: 'Betta Fish', stats: [{age: 1, color: ['blue', 'off White']}]}]