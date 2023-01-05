'use strict';

const longest = (line = []) => {
  let selected = ' ';
  for(const i of line){
    if(i.length > selected.length)
      selected = i;
  }
  return !isNaN(selected) ? 'Not found' : selected;
};

require('../Tests/longest.js')(longest);
