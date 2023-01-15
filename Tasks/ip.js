// Split string by the first occurrence of separator
//devided into two smaller functions

'use strict';
const Parseip = (IP) => {
  const REQUIRED_LENGTH = 4;
  const SPLIT_SYMBOL = '.';
  const ipArray = [];
  if (IP === '') return;
  const splittedIP = IP.split(SPLIT_SYMBOL);
  if (splittedIP.length !== REQUIRED_LENGTH) return;
  const result = fillIpArray(ipArray, splittedIP);

  return result;
};

const fillIpArray = (ipArray, splittedIP) => {
  let key = 0;
  for (const element of splittedIP) {
    ipArray[key] = parseInt(element);
    if (isNaN(ipArray[key])) return;
    key++;
  }
  return ipArray;
};

require('../Tests/ip.js')(Parseip);
