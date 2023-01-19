//Step 4
//Used reduce method to sum all array elements
//Reduced code space to minimal:)(this is joke)


const count = (obj) => Object.values(obj).filter((value) => typeof value === "number").reduce((acc, key) => acc + Number(key), 0);

require('../Tests/count.js')(count);
