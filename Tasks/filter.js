// Filter array by type name

'use strict';

Filter =(T,t)=> {
for (C of T) {
x = T.indexOf(C);
if (typeof T[x] !== t) { T.splice(x, 1) }; };
return T;
}

const result = Filter([1, 2, 'three', 4, 5, 'six'], 'number');
console.log(result);
