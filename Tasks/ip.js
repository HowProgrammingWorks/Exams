"use strict";
// Split string by the first occurrence of separator

const parseIp = (ip) => {
  const arr = [];
  const parsedIp = ip.split('.');
  if (parsedIp.length != 4) return;
  for(let i = 0; i < 4; i++){
    arr[i] = parseInt(persedIp[i]);
    if (isNaN(arr[index])) return;
  }
  return arr;
};

require('../Tests/ip.js')(parseIp);
