var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];

// How would print/log John's age?

console.log(users[1].age)

// How would you print/log the name of the first object?

console.log(users[0].name)

// How would you print the name and age of each user using a for loop? 
// Output should look like :
// Michael - 37
// John - 30
// David - 27

for (let i = 0; i < users.length; i++) {
    var current = users[i]
    console.log(`${current.name} - ${current.age}`)
}