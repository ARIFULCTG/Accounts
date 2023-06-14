use master
drop database Crystal
use Crystal
drop table Ledgers
create table Ledger
--delete from ledger
--delete from journal
go

select * from journal
select * from ledger

sp_help journal

select * from __EFMigrationsHistory
delete from __EFMigrationsHistory
drop table __EFMigrationsHistory
use master

drop database Crystal
