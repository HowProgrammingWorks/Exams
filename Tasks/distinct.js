// Deduplicate values in array
'use strict';

const deduplicate = arr => {
  const set = new Set();
  let index = 0;
  arr.forEach((value) => {
    if (set.has(value)) {
      arr.splice(index, 1);
    } 
    else {
      set.add(value);
    };
    index++;
  });
  return arr;
}

const duplArr = [1, 2, 1, 3, 1, 4, 4];
const result = deduplicate(duplArr);
console.dir({
  'array with duplicates': duplArr,
  'result' : result
});
