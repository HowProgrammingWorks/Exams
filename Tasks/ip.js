// Split string by the first occurrence of separator

'use strict';

const parseIp = (ipAddress) => {
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

console.log(parseIp('127.0.0.1'));
