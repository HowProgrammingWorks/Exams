"use strict";
// Split string by the first occurrence of separator

const parseIp = (ip) => {
  const arr = [];
  if (ip === '') return;
  else {
    const parsedIp = ip.split('.');
    if (parsedIp.length != 4) return;
    let index = 0;
    for (const el of parsedIp) {
      arr[index] = parseInt(el);
      if (isNaN(arr[index])) return;
      index++;
    }
  }
  return arr;
};

require('../Tests/ip.js')(parseIp);
