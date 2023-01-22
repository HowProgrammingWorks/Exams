'use strict';
// Split string by the first occurrence of separator

const AMOUNT_NUMBERS_IN_IP = 4;

const parseIp = (ip) => {
  const arr = ip.split('.');
  if (arr.length !== AMOUNT_NUMBERS_IN_IP) return;
  for (let i = 0; i < AMOUNT_NUMBERS_IN_IP; i++) {
    arr[i] = parseInt(arr[i]);
    if (isNaN(arr[i])) return;
  }
  return arr;
};

require('../Tests/ip.js')(parseIp);
