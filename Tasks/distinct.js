// Deduplicate values in array
'use strict';

const deduplicate = data => {
  const A = new Set();
  let w = 0;
  data.forEach((a) => {
    if (A.has(a)) {
      data.splice(w, 1);
    } 
    else {
      A.add(a);
    };
    w++;
  });
  return data;
}

const result = deduplicate([1, 2, 1, 3, 1, 4]);
console.log(result);
