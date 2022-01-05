'use strict';

const getValueBetween = (str, start, end) => {
  let startIndex = str.indexOf(start);
  
  if (startIndex === -1) {
    return '';
  }

  startIndex += start.length;
  str = str.substring(startIndex);

  if (end && str.indexOf(end) === -1) {
    return '';    
  }

  const endIndex = str.indexOf(end);
  str =  str.substring(0 , endIndex);
  return str;   
};

const result = getValueBetween('Hello <username> and bye!', '<', '>');
console.log(result);
