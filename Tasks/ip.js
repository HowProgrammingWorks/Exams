// Split string by the first occurrence of separator

//Add use strict
//Change variables
//remove "Magic values"

'use strict';
const Parseip = (IP) => {
  const REQUIRED_LENGTH = 4;
  const SPLIT_SYMBOL = '.';

  const ipArray = [];

  if (IP === '') return;
  else {
    const splittedIp = IP.split(SPLIT_SYMBOL);
    if (splittedIp.length !== REQUIRED_LENGTH) return;

    let key = 0;
    for (const element of splittedIp) {
      ipArray[key] = parseInt(element);
      if (isNaN(ipArray[key])) return;
      key++;
    }
  }
  return ipArray;
};

require('../Tests/ip.js')(Parseip);
