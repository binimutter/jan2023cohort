var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "root",
  database: "toys"
});

let data = []

// -- Show all the toys that are in the home

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "select * from toys;"
    con.query(sql, function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      data = result
      return data
    });
  });
  console.log('index 1:', data[0])

// -- Show all the toys that 1 child has

// -- SELECT toys.name
// -- FROM toys
// -- LEFT JOIN children_has_toys
// -- ON children_has_toys.toys_id = toys.id
// -- WHERE children_id = 2;

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "select toys.name from toys left join children_has_toys on children_has_toys.toys_id = toys.id where children_id = 2;"
    con.query(sql, function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      data = result
      return data
    });
  });

// -- Show who owns 1 type of toy

// -- SELECT *
// -- FROM children
// -- LEFT JOIN children_has_toys
// -- ON children_has_toys.children_id = children.id
// -- LEFT JOIN toys
// -- ON children_has_toys.toys_id = toys.id
// -- WHERE toys.type = 'doll';

con.connect(function(err) {
  if (err) throw err;
  console.log("Connected!");
  var sql = "select * from children left join children_has_toys on children_has_toys.children_id = children.id left join toys on children_has_toys.toys_id = toys.id where toys.type = 'doll';"
  con.query(sql, function (err, result, fields) {
    if (err) throw err;
    console.log(result);
    data = result
    return data
  });
});


// -- Update the name to 1 child

// -- UPDATE children SET
// -- firstName = 'May' WHERE
// -- id = 1;

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "update children set firstName = 'Dec' WHERE id = 1;"
    con.query(sql, function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      data = result
      return data
    });
  });


// -- delete a toy from a child

// -- DELETE FROM children_has_toys WHERE
// -- toys_id = 1;

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    var sql = "delete from children_has_toys where toys_id = 1;"
    con.query(sql, function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      data = result
      return data
    });
  });


