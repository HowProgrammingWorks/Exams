// Deduplicate values in array
'use strict';

const deduplicate = ([...arr]) => {
  const set = new Set();
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    if (set.has(value)) {
      arr.splice(i, 1);
      i--;
    } 
    else {
      set.add(value);
    }
  }
  return arr;
}

const duplArr = [1, 2, 1, 3, 1, 4, 4];
const result = deduplicate(duplArr);
console.dir({
  'array with duplicates': duplArr,
  'result' : result
});
