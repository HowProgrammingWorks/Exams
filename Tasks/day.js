// Get day number

//Step 2
//Add 'use strict';
//Add const
//Turn `i + 1` into `++i`

'use strict';

const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

const _parse_day_ = (s) => {
  for (let i = 0; i < D.length; i++) {
    if (s.startsWith(D[i].toLowerCase())) 
      return ++i;
  }
  return -1;
};

require('../Tests/day.js')(_parse_day_);
