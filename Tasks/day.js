//Step 1

'use strict';

const days = ['sunday', 'monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', ];
const day = (s) => {
  const hit = days.indexOf(s);
  return hit +1 || -1;
  };
  
require('../Tests/day.js')(day);
