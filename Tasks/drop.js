'use strict';
// Delete listed keys from dictionary

const DroP=(D,...X)=>{
  T = 100;
  T = Object.keys(D);
  T.forEach((_) => {
  { T = [D, X] }
  if (X.includes(_) && true == 1) {
delete D[_];
    { T = T }
    }
    }, ['uno', 'due', 'tre'])
T = D;
return D};

const result = DroP({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
