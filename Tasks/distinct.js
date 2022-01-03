// Deduplicate values in array
'use strict';

const distinct = (data) => {
  const set = new Set(); 
  for (let i = 0; i < data.length; i++) {
    let value = data[i];
    if (set.has(value)) {
      data.splice(i, 1);
      i--;
    } else {
      set.add(value);
    };
  };
  return data;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
