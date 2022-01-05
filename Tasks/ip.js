// Split string by the first occurrence of separator

'use strict';

const ParseIp = ipAddress => {
  let separatedIpAddress = [];
  if (ipAddress === '') return 0;
  else {
    separatedIpAddress = ipAddress.split('.');
    let index = 0;
    for (const arrayElement of separatedIpAddress) {
      separatedIpAddress[index] = parseInt(arrayElement);
      index++;
    }
  }
  return separatedIpAddress;
};

console.log(ParseIp('127.0.0.1'));
