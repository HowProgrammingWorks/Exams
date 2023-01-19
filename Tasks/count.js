//Step 2
//Reduced code in function
//Removed other useless things


const count = (obj) => {
 let sum = 0;
  
  Object.keys(obj).forEach((key) => {
    if (typeof obj[key] === 'number') sum += obj[key];
  });
  
  return sum;
};

require('../Tests/count.js')(count);
