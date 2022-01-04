// Get day number
'use strict'


_parse_day_=s=>{
  let i; for(i=0;i<D.length;i++){
  if(s.startsWith(D[i].toLowerCase())){return i +1};};return -1;
};
const D = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
const result = _parse_day_('friday')
console.log(result)
