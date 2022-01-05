// Split string by the first occurrence of separator

'use strict';

const ParseIp = ipAddress => {
  let separatedIpAddress = [];
  if (ipAddress === '') return 0;
  else {
    let separator = ipAddress.split('.');
    let index = 0;
    for (const arrayElement of separator) {
      separatedIpAddress[index] = parseInt(arrayElement);
      index++;
    }
  }
  return separatedIpAddress;
};

const result = ParseIp('127.0.0.1');
console.log(result);
