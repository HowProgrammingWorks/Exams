const Parse_Day = (S) => {
const Day = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
let i;
const AmountDay = Day.length;
for (i = 0; i < AmountDay; i++) {
    let IndexDay = Day.indexOf(Day[i]);
    let NumberDay = IndexDay + 1;
    console.log (`Day: ${Day[i]}, his naumber ${NumberDay}`)
  }
  return;
};
const day_js = Parse_Day(1);
