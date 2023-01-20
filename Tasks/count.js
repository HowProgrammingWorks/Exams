// Step 3 
// Sort and sum elements using array methods

const count = (obj) => {
  let sum = 0;
  Object.values(obj)
    .filter((value) => typeof value === "number")
    .map((key) => {
      sum += Number(key);
    });

  return sum;
}

require('../Tests/count.js')(count);
