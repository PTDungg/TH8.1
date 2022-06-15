create database qli_sv
use qli_sv

create table SINHVIEN
(
	ma_sv varchar(50) primary key not null,
	ten_sv nvarchar(50),
	ngay_sinh date,
	gioi_tinh nvarchar(50),
	dia_chi nvarchar(50),
)
select * from SINHVIEN where ma_sv like '1' or ten_sv like N'Hưng' or gioi_tinh like 'Nam'