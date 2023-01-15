// Sum all numbers from an array
'use strict';

const sum = (args) => {
  let res = 0;
  const array = args.flat(Infinity);
  for(let i = 0; i < array.length; i++){
    if (typeof array[i] === 'number'){
      res += array[i];
    }
  }
  return res;
}

require('../Tests/sum.js')(sum);
