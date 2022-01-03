'use strict';

// Remove values from array

const Skip =(T,...Remove)=> {
let x = 0;
for (const C of T) {
for (const X of Remove) {
if (C === X) {
  T.splice(x, 1);
};
}
x++;
}
return T;
}

const result = Skip([1, 2, 3, 4, 5], 2, 5);
console.log(result);
