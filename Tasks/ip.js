// Split string by the first occurrence of separator
'use strict';

const parseIp = ip => {
  const res = []
    if (ip === '' ) return 0  ;
  else {
  const array = ip.split('.');
  let i = 0
    for ( const key of array) {
  res[i] = parseInt(key);
  i++;
  }};
  return res;
};

const result = parseIp('127.0.0.1')
console.log(result)
