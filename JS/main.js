 var startYear = 2020;
 var yearsCount = 10;

for (let i = 0; i < yearsCount; i++)
{
    let currentDate = new Date(startYear+i, 8, 1, 12, 0, 0);

    let d = new Date(startYear+i, 0, 1),
        d1 = d.getTime (),
        dd = d.getDay (),
        res = Math.floor ((currentDate - d1) / 8.64e7) + (dd ? dd - 1 : 6),
        week = ((Math.floor (res / 7) % 2) ? 'НЕ' : '') + 'ЧЕТНАЯ ' + 'НЕДЕЛЯ';
    console.log(currentDate + " - " + Math.floor (res / 7) + " -> " + week);
}