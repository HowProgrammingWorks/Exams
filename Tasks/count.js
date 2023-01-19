//Step 3
//Used array methods to sort and sum elements
//Cleared useless things

const count = (obj) => {
  let sum = 0;
  Object.values(obj)
    .filter((value) => typeof value === "number")
    .map((key) => {
      sum += Number(key);
    });

  return sum;
};
require('../Tests/count.js')(count);
