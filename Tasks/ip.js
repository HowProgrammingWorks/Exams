'use strict';

const parseIp = (ip) => {
  const value = [];
  const splitArr = ip.split('.');
  for (let i = 0; i < splitArr.length; i++) {
    value[i] = parseInt(splitArr[i]);
  }
  return value;
};

console.log(parseIp('127.0.0.1'));
