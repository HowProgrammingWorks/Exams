'use strict'

 const adder = (obj) => {
  let sum = 0;
  const keys = Object.values(obj);
  for (const key of keys) {
    if (typeof key === 'number') sum += key;
  }
  return sum;
};

require('../Tests/count.js')(adder);
