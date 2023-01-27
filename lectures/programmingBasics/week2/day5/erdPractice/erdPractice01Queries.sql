-- Active: 1674574307291@@127.0.0.1@3306@toys
var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "root",
  database: "toys"
});

// con.connect(function(err) {
//   if (err) throw err;
//   console.log("Connected!");
// });
let data = []

-- con.connect(function(err) {
--     if (err) throw err;
--     console.log("Connected!");
--     // var sql = "select * from animal left join farm_has_animal on animal.id=farm_has_animal.animal_id left join farm on farm_has_animal.farm_id=farm.id;";
--     var sql = "select * from farm left join farm_has_animal on farm.id=farm_has_animal.farm_id left join animal on farm_has_animal.animal_id=animal.id;"
--     con.query(sql, function (err, result, fields) {
--       if (err) throw err;
--       console.log(result);
--       data = result
--       return data
--     });
--   });
--   console.log('index 1:', data[0])

-- Show all the toys that are in the home
SELECT * FROM toys;

-- Show all the toys that 1 child has
SELECT toys.name
FROM toys
LEFT JOIN children_has_toys
ON children_has_toys.toys_id = toys.id
WHERE children_id = 2;

-- Show who owns 1 type of toy

SELECT *
FROM children
LEFT JOIN children_has_toys
ON children_has_toys.children_id = children.id
LEFT JOIN toys
ON childrens_has_toys.toys_id = toys.id
WHERE toys.type = 'doll';


-- Update the name to 1 child
UPDATE children SET
firstName = 'May' WHERE
id = 1;


-- delete a toy from a child

DELETE FROM children_has_toys WHERE
toys_id = 1;


