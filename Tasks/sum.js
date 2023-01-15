// Sum all numbers from an array
'use strict';

function sum(...args) {
  let res = 0;
  let array;
  array = args.flat(Infinity);
  for(let i = 0; i<array.length; i++){
    if (typeof array[i] === 'number'){
      res += array[i];
    }
    else {
      continue;
    }
  }
  return res;
}

require('../Tests/sum.js')(sum);
