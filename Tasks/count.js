// Step 1 
// Added let and const for creating variables
// Removed useless lexical environment creations like {}

const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  keys.forEach((key) => { 
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
