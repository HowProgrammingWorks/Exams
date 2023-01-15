// Sum all numbers from an array
'use strict';

const sum = (args) => {
  let res = 0;
  const array = args.flat(Infinity);
  for(const value of array){
    if (typeof value === 'number'){
      res += value;
    }
  }
  return res;
}

require('../Tests/sum.js')(sum);
