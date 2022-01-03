// Split string by the first occurrence of separator
'use strict';

const parseIp = (ip) => {
  const res = [];
  if (ip === '') return 0;
  else {
    const array = ip.split('.');
    for (let i = 0; i < array.length; i++) {
      const key = array[i];
      res[i] = parseInt(key);
    }
  }
  return res;
};

const result = parseIp('127.0.0.1');
console.log(result);
