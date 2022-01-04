'use strict'
// Deduplicate values in array

const DISTINCT =data=> {
    const A=new Set(); 
    let w = 0;
    data.forEach((a) => {
        if (A.has(a)) {
        data.splice(w, 1)
        } else {
        A.add(a)
        };
        w++;
    });
  return data;}

const result = DISTINCT([1, 2, 1, 3, 1, 4]);
console.log(result);
