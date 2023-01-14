'use strict'

 const adder = (obj) => {
  let sum = 0;
  const arrValues = Object.values(obj);
  for (const element of arr_of_values) {
    if (typeof element === 'number') sum += element;
  }
  return sum;
};

require('../Tests/count.js')(adder);
