# Generated by Django 2.2.6 on 2019-10-22 12:40

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('geo', '0004_auto_20191022_2009'),
    ]

    operations = [
        migrations.AlterField(
            model_name='geodata',
            name='geodata_sdate',
            field=models.IntegerField(verbose_name='确诊日期'),
        ),
    ]