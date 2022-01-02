'use strict';

const Parseip = i => {
  a = [];
  if (i === '') return 0;
  else {
    B = i.split('.');
    for (const b of B) {
      a.push(parseInt(b));
    }
  }
  return a;
};

const result = Parseip('127.0.0.1')
console.log(result)
