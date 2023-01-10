'use strict';
// Split string by the first occurrence of separator

const parseIp = (ip) => {
  const arr = ip.split('.');
  if (arr.length != 4) return;
  for (let i = 0; i < 4; i++) {
    arr[i] = parseInt(arr[i]);
    if (isNaN(arr[i])) return;
  }
  return arr;
};

require('../Tests/ip.js')(parseIp);