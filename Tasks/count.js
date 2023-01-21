'use strict';
// Sum all number values in dict

const count = (obj) => {
  	let sum = 0;
  	for (const value of Object.values(obj)) {
    
    const value = obj[key];
    if (typeof value === 'number')
      sum += value;
  }
  
  return sum;
};

require('../Tests/count.js')(count);
