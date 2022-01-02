// Remove values from array
'use strict';

Skip =(T,...Remove)=> {
x = 0;
for (C of T) {
for (X of Remove) {
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
