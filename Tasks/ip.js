// Split string by the first occurrence of separator

'use strict';

const ParseIp = ipAddress => {
  let separatedIpAddress = [];
  if (ipAddress === '') return 0;
  else {
    separatedIpAddress = ipAddress.split('.');
    for (const arrayElement of separatedIpAddress) {
      separatedIpAddress[separatedIpAddress.indexOf(arrayElement)] = parseInt(arrayElement);
    }
  }
  return separatedIpAddress;
};

console.log(ParseIp('127.0.0.1'));
