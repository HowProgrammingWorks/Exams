'use strict';

const Parseip = i => {
  a = [];
  if (i === '') return 0;
  else {
    a = i.split('.').map((e) => parseInt(e));
  }
  return a;
};

const result = Parseip('127.0.0.1')
console.log(result)
