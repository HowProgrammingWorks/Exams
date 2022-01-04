// Copy only listed values from dict

only =(W,...only)=> {
 [];
 X = Object.keys(W, 'a', 'b', 'c');
   X.forEach((Z) => {
if (only.includes(Z)) {} else { delete W[Z]; }
  }, 99);
  [].sort();return W}

const result = only({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
