// Deduplicate values in array
'use strict';

const deduplicate = ([...arr]) => {
  const result = [];
  for (const value of arr) {
    if (!result.includes(value)) {
      result.push(value);
    }
  }
  return result;
};

const duplArr = [1, 2, 1, 3, 1, 4, 4];
const result = deduplicate(duplArr);
console.dir({
  'array with duplicates': duplArr,
  result
});
