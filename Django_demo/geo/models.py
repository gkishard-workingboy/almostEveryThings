from django.db import models

# Create your models here.
class geodata(models.Model):
    geodata_order = models.IntegerField('爆发顺序')
    geodata_farmsize = models.IntegerField('养殖场规模')
    geodata_totalnum = models.IntegerField('发病数')
    geodata_deathnum = models.IntegerField('死亡数')
    geodata_oie = models.IntegerField('OIE')
    geodata_sdate = models.IntegerField('确诊日期')
    geodata_place = models.CharField('发生地',max_length=255)
    geodata_coordinates = models.CharField('坐标',max_length=100,blank=True,null=True)

    class Meta:
        db_table='demo_data'

    def __str__(self):
        return self.geodata_province+self.geodata_city+self.geodata_county
