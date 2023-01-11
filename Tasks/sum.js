'use strict';
function sumOfElement(...args) {
  let result = 0;
  const values = args.flat(Infinity);
  for (const value of values) {
    if (typeof value === 'number') {
      result += value;
    }
  }
  return result;
}

require('../Tests/sum.js')(sumOfElement);
