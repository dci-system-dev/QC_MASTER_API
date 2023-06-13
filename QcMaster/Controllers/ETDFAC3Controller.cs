using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QcMaster.Contexts;
using QcMaster.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QcMaster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ETDFAC3Controller : Controller
    {
        private readonly DbETDFAC3 _contextDbEtdFac3;
        private readonly dbSCM _contextDbSCM;

        public ETDFAC3Controller(DbETDFAC3 contextDbEtdFac3, dbSCM contextDbSCM)
        {
            _contextDbEtdFac3 = contextDbEtdFac3;
            _contextDbSCM = contextDbSCM;
        }

        [HttpPost]
        [Route("/fh/add")]
        public async Task<IActionResult> FrontHead(EtdFhDetail props)
        {
            EtdFhDetail item = new EtdFhDetail();
            item.FhId = props.FhId;
            item.FhId1 = props.FhRank;
            item.FhId2 = -999;
            item.FhRank = Convert.ToDouble(props.FhRank);
            item.FhRankC = "OK";
            item.FhJudgeRoundness = props.FhJudgeRoundness;
            item.FhCylindricity = props.FhCylindricity;
            item.FhPerpendicularity = props.FhPerpendicularity;
            item.FhConcentricity = props.FhConcentricity;
            item.FhJudgement = "OK";
            item.FhDate = DateTime.Now;
            _contextDbEtdFac3.EtdFhDetails.Add(item);

            EtdFhFlatness itemFlatNess = new EtdFhFlatness();
            itemFlatNess.FhId = props.FhId;
            itemFlatNess.FhFl1JudgeRank = "OK";
            itemFlatNess.FhFl1Judge = 0;
            itemFlatNess.FhFl2JudgeRank = "OK";
            itemFlatNess.FhFl2Judge = 0;
            itemFlatNess.FhFlJudgement = "OK";
            itemFlatNess.FhFlDate = DateTime.Now;
            _contextDbEtdFac3.EtdFhFlatnesses.Add(itemFlatNess);

            EtdFrontHead itemFrontHead = new EtdFrontHead();
            itemFrontHead.FhId = props.FhId;
            itemFrontHead.ProId = "20";
            itemFrontHead.MId = props.Mid;
            itemFrontHead.FhPosition = 0;
            itemFrontHead.FhJudgement = "OK";
            itemFrontHead.FhLine = "FH_FINISH_FAC3";
            itemFrontHead.FhDate = DateTime.Now;
            itemFrontHead.FirstStamptime = DateTime.Now;
            _contextDbEtdFac3.EtdFrontHeads.Add(itemFrontHead);

            var newItem = await _contextDbEtdFac3.SaveChangesAsync();
            if (newItem > 0)
            {
                return Ok(new { status = true });
            }
            else
            {
                return Ok(new { status = false });
            }

        }

        [HttpPost]
        [Route("/rh/add")]
        public async Task<IActionResult> RearHead(EtdRhDetail props)
        {
            EtdRhDetail item = new EtdRhDetail();
            item.RhId = props.RhId;
            item.RhRank = Convert.ToDouble(props.RhRank);
            item.RhJudgeRoundness = props.RhJudgeRoundness;
            item.RhCylindricity = props.RhCylindricity;
            item.RhPerpendicularity = props.RhPerpendicularity;
            item.RhJudgement = "OK";
            item.RhRankC = "A";
            item.RhDate = DateTime.Now;
            _contextDbEtdFac3.EtdRhDetails.Add(item);


            EtdRhFlatness itemFlatNess = new EtdRhFlatness();
            itemFlatNess.RhId = props.RhId;
            itemFlatNess.RhFl1JudgeRank = "OK";
            itemFlatNess.RhFl1Judge = 0;
            itemFlatNess.RhFl2JudgeRank = "OK";
            itemFlatNess.RhFl2Judge = 0;
            itemFlatNess.RhFlJudgement = "OK";
            itemFlatNess.RhFlDate = DateTime.Now;
            _contextDbEtdFac3.EtdRhFlatnesses.Add(itemFlatNess);

            EtdRearHead itemRearHead = new EtdRearHead();
            itemRearHead.RhId = props.RhId;
            itemRearHead.ProId = "99";
            itemRearHead.MId = props.Mid;
            itemRearHead.RhPosition = 0;
            itemRearHead.RhJudgement = "OK";
            itemRearHead.RhLine = "RH_ID_FL_FAC3";
            itemRearHead.RhDate = DateTime.Now;
            itemRearHead.FirstStamptime = DateTime.Now;
            _contextDbEtdFac3.EtdRearHeads.Add(itemRearHead);

            var newItem = await _contextDbEtdFac3.SaveChangesAsync();
            if (newItem > 0)
            {
                return Ok(new { status = true });
            }
            else
            {
                return Ok(new { status = false });
            }

        }

        [HttpPost]
        [Route("/cs/add")]
        public async Task<IActionResult> CrankShaft([FromBody] ChankShaftDataSet props)
        {
            EtdCsOdFr itemCsOd = new EtdCsOdFr();
            itemCsOd.CsId = props.CsId;
            itemCsOd.CsFrFRank = Convert.ToDouble(props.CsFrFRank);
            itemCsOd.CsFrFRankC = "A";
            itemCsOd.CsFrRRank = Convert.ToDouble(props.CsFrRRank);
            itemCsOd.CsFrRRankC = "A";
            //itemCsOd.CsFrFJudgeRoundness = Convert.ToDouble(props.CsFrFJudgeRoundness);
            itemCsOd.CsFrRJudgeRoundness = Convert.ToDouble(props.CsFrRJudgeRoundness);
            itemCsOd.CsFrFCylindricity = Convert.ToDouble(props.CsFrFCylindricity);
            itemCsOd.CsFrRCylindricity = Convert.ToDouble(props.CsFrRCylindricity);
            itemCsOd.CsFrJudgement = "OK";
            itemCsOd.CsFrDate = DateTime.Now;
            _contextDbEtdFac3.EtdCsOdFrs.Add(itemCsOd);

            EtdCsEcc ItemEcc = new EtdCsEcc();
            ItemEcc.CsId = props.CsId;
            ItemEcc.CsEccRank = Convert.ToDouble(props.CsEccRank);
            ItemEcc.CsEccRankC = "A";
            ItemEcc.CsEccJudgement = "OK";
            ItemEcc.CsEccDate = DateTime.Now;
            _contextDbEtdFac3.EtdCsEccs.Add(ItemEcc);

            EtdCsOdPin itemCsPin = new EtdCsOdPin();
            itemCsPin.CsId = props.CsId;
            itemCsPin.CsPinRankC = "A";
            itemCsPin.CsPinRank = Convert.ToDouble(props.CsPinRank);
            itemCsPin.CsPinJudgeRoundness = Convert.ToDouble(props.CsPinJudgeRoundness);
            itemCsPin.CsPinJudgement = "OK";
            itemCsPin.CsPinCylindricity = Convert.ToDouble(props.CsPinCylindricity);
            itemCsPin.CsPinDate = DateTime.Now;

            EtdCrankShaft itemCrankShaft = new EtdCrankShaft();
            itemCrankShaft.CsId = props.CsId;
            itemCrankShaft.ProId = "6";
            itemCrankShaft.MId = props.Mid;
            itemCrankShaft.CsPosition = 0;
            itemCrankShaft.CsJudgement = "OK";
            itemCrankShaft.CsLine = "CS_PE_FAC3";
            itemCrankShaft.CsDate = DateTime.Now;
            itemCrankShaft.FirstStamptime = DateTime.Now;
            _contextDbEtdFac3.EtdCrankShafts.Add(itemCrankShaft);


            _contextDbEtdFac3.EtdCsOdPins.Add(itemCsPin);
            var insertEcc = await _contextDbEtdFac3.SaveChangesAsync();

            if (insertEcc > 0)
            {
                return Ok(new { status = true });
            }
            else
            {
                return Ok(new { status = false });
            }
        }


        [HttpPost]
        [Route("/cy/add")]
        public async Task<IActionResult> Cylinder([FromBody] CylinderDataSet props)
        {
            EtdCyIdBush itemCyOd = new EtdCyIdBush();
            itemCyOd.CyId = props.CyId;
            itemCyOd.CyBuRank = Convert.ToDouble(props.CyBuRank);
            itemCyOd.CyBuRankC = "A";
            itemCyOd.CyBuJudgeRoundness = Convert.ToDouble(props.CyBuJudgeRoundness);
            itemCyOd.CyBuPerpendicularity = Convert.ToDouble(props.CyBuPerpendicularity);
            itemCyOd.CyBuCylindricity = Convert.ToDouble(props.CyBuCylindricity);
            itemCyOd.CyBuJudgement = "OK";
            itemCyOd.CyBuDate = DateTime.Now;
            _contextDbEtdFac3.EtdCyIdBushes.Add(itemCyOd);

            EtdCyIdBore itemBore = new EtdCyIdBore();
            itemBore.CyId = props.CyId;
            itemBore.CyBoRankC = "A";
            itemBore.CyBoRank = Convert.ToDouble(props.CyBoRank);
            itemBore.CyBoJudgeRoundness = Convert.ToDouble(props.CyBoJudgeRoundness);
            itemBore.CyBoPerpendicularity = Convert.ToDouble(props.CyBoPerpendicularity);
            itemBore.CyBoCylindricity = Convert.ToDouble(props.CyBoCylindricity) ;
            itemBore.CyBoConcentricity = Convert.ToDouble(props.CyBoConcentricity);
            itemBore.CyBoJudgement = "OK";
            itemBore.CyBoDate = DateTime.Now;
            _contextDbEtdFac3.EtdCyIdBores.Add(itemBore);

            EtdCyHeight itemHeight = new EtdCyHeight();
            itemHeight.CyId = props.CyId;
            itemHeight.CyHeRank = Convert.ToDouble(props.CyHeRank);
            itemHeight.CyHeRankC = "A";
            itemHeight.CyHeParallism = Convert.ToDouble(props.CyHeParallism);
            itemHeight.CyHeJudgement = "OK";
            itemHeight.CyHeDate = DateTime.Now;
            _contextDbEtdFac3.EtdCyHeights.Add(itemHeight);


            EtdCylinder itemCylinder = new EtdCylinder();
            itemCylinder.CyId = props.CyId;
            itemCylinder.ProId = "99";
            itemCylinder.MId = props.Mid;
            itemCylinder.CyPosition = 0;
            itemCylinder.CyJudgement = "OK";
            itemCylinder.CyLine = "CY_HEI_FAC3";
            itemCylinder.CyDate = DateTime.Now;
            itemCylinder.FirstStamptime = DateTime.Now;
            _contextDbEtdFac3.EtdCylinders.Add(itemCylinder);


            var insertEcc = await _contextDbEtdFac3.SaveChangesAsync();

            if (insertEcc > 0)
            {
                return Ok(new { status = true });
            }
            else
            {
                return Ok(new { status = false });
            }
        }

        [HttpGet]
        [Route("/qcstd/get/{type}/{id}")]
        public async Task<IActionResult> GetQcStdById(string type, string id)
        {
            switch (type)
            {
                case "fh":
                    var FH = _contextDbEtdFac3.EtdFhDetails.Where(x => x.FhId == id).ToList();
                    var result = from item in FH
                                 select new
                                 {
                                     code = item.FhId,
                                     item.FhJudgeRoundness,
                                     item.FhRank,
                                     item.FhCylindricity,
                                     item.FhPerpendicularity,
                                     item.FhConcentricity,
                                     mid = (from tbFrondHead in _contextDbEtdFac3.EtdFrontHeads.Where(x => x.FhId == item.FhId).ToList() select tbFrondHead.MId).FirstOrDefault()
                                 };
                    return Ok(result.FirstOrDefault());
                case "rh":
                    var RH = _contextDbEtdFac3.EtdRhDetails.Where(x => x.RhId == id).ToList();
                    return Ok((from item in RH
                               select new
                               {
                                   code = item.RhId,
                                   item.RhJudgeRoundness,
                                   item.RhRank,
                                   item.RhCylindricity,
                                   item.RhPerpendicularity,
                                   mid = (from tbFrondHead in _contextDbEtdFac3.EtdRearHeads.Where(x => x.RhId == item.RhId).ToList() select tbFrondHead.MId).FirstOrDefault()
                               }).FirstOrDefault());
                case "cs":
                    var CS_FR = _contextDbEtdFac3.EtdCsOdFrs.Where(x => x.CsId == id).ToList();
                    var CS_PIN = _contextDbEtdFac3.EtdCsOdPins.Where(x => x.CsId == id).ToList();
                    var CS_ECC = _contextDbEtdFac3.EtdCsEccs.Where(x => x.CsId == id).ToList();
                    var CrankShaft = _contextDbEtdFac3.EtdCrankShafts.Where(x => x.CsId == id).ToList();
                    var resultCS = (from item in CS_FR
                                    select new
                                    {
                                        code = item.CsId,
                                        csFrRJudgeRoundness = item.CsFrRJudgeRoundness,
                                        csFrFJudgeRoundness = item.CsFrFJudgeRoundness,
                                        csFrFRank = item.CsFrFRank,
                                        csFrRRank = item.CsFrRRank,
                                        csFrFCylindricity = item.CsFrFCylindricity,
                                        csFrRCylindricity = item.CsFrRCylindricity,
                                        csPinRank = (from pin in CS_PIN select pin.CsPinRank).FirstOrDefault(),
                                        csPinJudgeRoundness = (from pin in CS_PIN select pin.CsPinJudgeRoundness).FirstOrDefault(),
                                        csPinCylindricity = (from pin in CS_PIN select pin.CsPinCylindricity).FirstOrDefault(),
                                        csEccRank = (from ecc in CS_ECC select ecc.CsEccRank).FirstOrDefault(),
                                        mid = (from cs in CrankShaft select cs.MId).FirstOrDefault()
                                    }).FirstOrDefault();

                    return Ok(resultCS);
                case "cy":
                    var cylinder = _contextDbEtdFac3.EtdCylinders.Where(x => x.CyId == id).ToList();
                    var cyBush = _contextDbEtdFac3.EtdCyIdBushes.Where(x => x.CyId == id).ToList();
                    var cyBore = _contextDbEtdFac3.EtdCyIdBores.Where(x => x.CyId == id).ToList();
                    var cyHeight = _contextDbEtdFac3.EtdCyHeights.Where(x => x.CyId == id).ToList();
                    var cyResult = (from item in cyBush
                                    select new
                                    {
                                        code = item.CyId,
                                        item.CyBuRank,
                                        item.CyBuCylindricity,
                                        item.CyBuJudgeRoundness,
                                        item.CyBuPerpendicularity,
                                        CyBoRank = (from bo in cyBore select bo.CyBoRank).FirstOrDefault(),
                                        CyBoJudgeRoundness = (from bo in cyBore select bo.CyBoJudgeRoundness).FirstOrDefault(),
                                        cyBoCylindricity = (from bo in cyBore select bo.CyBoCylindricity).FirstOrDefault(),
                                        CyBoPerpendicularity = (from bo in cyBore select bo.CyBoPerpendicularity).FirstOrDefault(),
                                        CyBoConcentricity = (from bo in cyBore select bo.CyBoConcentricity).FirstOrDefault(),
                                        CyHeRank = (from bo in cyHeight select bo.CyHeRank).FirstOrDefault(),
                                        CyHeParallism = (from bo in cyHeight select bo.CyHeParallism).FirstOrDefault(),
                                        mid = (from cy in cylinder select cy.MId).FirstOrDefault()
                                    }).FirstOrDefault();
                    return Ok(cyResult);
                case "pt":
                    var piston = _contextDbEtdFac3.EtdPistons.Where(x => x.PtId == id).ToList();
                    var ptOd = _contextDbEtdFac3.EtdPtOds.Where(x => x.PtId == id).ToList();
                    var ptId = _contextDbEtdFac3.EtdPtIds.Where(x => x.PtId == id).ToList();
                    var ptHeight = _contextDbEtdFac3.EtdPtHeights.Where(x => x.PtId == id).ToList();
                    var ptBland = _contextDbEtdFac3.EtdPtBlades.Where(x => x.PtId == id).ToList();
                    var ptResult = (from item in ptId
                                    select new
                                    {
                                        code = item.PtId,
                                        item.PtIdRank,
                                        item.PtIdRoundness,
                                        item.PtIdCylindricity,
                                        item.PtIdPerpendicularity,
                                        item.PtIdConcentricity,
                                        PtOdRank = (from od in ptOd select od.PtOdRank).FirstOrDefault(),
                                        PtOdJudgeRoundness = (from od in ptOd select od.PtOdJudgeRoundness).FirstOrDefault(),
                                        PtOdCylindricity = (from od in ptOd select od.PtOdCylindricity).FirstOrDefault(),
                                        PtOdPerpendicularity = (from od in ptOd select od.PtOdPerpendicularity).FirstOrDefault(),
                                        PtBlRank = (from bland in ptBland select bland.PtBlRank).FirstOrDefault(),
                                        PtBlParallism = (from bland in ptBland select bland.PtBlParallism).FirstOrDefault(),
                                        PtHeRank = (from height in ptHeight select height.PtHeRank).FirstOrDefault(),
                                        PtHeParallism = (from height in ptHeight select height.PtHeParallism).FirstOrDefault(),
                                        mid = (from pt in piston select pt.MId).FirstOrDefault()
                                    }).FirstOrDefault();
                    return Ok(ptResult);
            }
            return Ok();
        }

        [HttpGet]
        [Route("/del/{type}/{id}")]
        public async Task<IActionResult> DelQcStd(string type, string id)
        {
            switch (type)
            {
                case "fh":
                    var itemFH = _contextDbEtdFac3.EtdFhDetails.SingleOrDefault(x => x.FhId == id);
                    var itemFrontHead = _contextDbEtdFac3.EtdFrontHeads.SingleOrDefault(x => x.FhId == id);
                    var itemFlatness = _contextDbEtdFac3.EtdFhFlatnesses.SingleOrDefault(x => x.FhId == id);
                    if (itemFH != null && itemFrontHead != null && itemFlatness != null)
                    {
                        _contextDbEtdFac3.EtdFhDetails.Remove(itemFH);
                        _contextDbEtdFac3.EtdFrontHeads.Remove(itemFrontHead);
                        _contextDbEtdFac3.EtdFhFlatnesses.Remove(itemFlatness);
                        await _contextDbEtdFac3.SaveChangesAsync();
                    }
                    break;
                case "rh":
                    var itemRH = _contextDbEtdFac3.EtdRhDetails.SingleOrDefault(x => x.RhId == id);
                    var itemReadhead = _contextDbEtdFac3.EtdRearHeads.SingleOrDefault(x => x.RhId == id);
                    var itemRhFlatness = _contextDbEtdFac3.EtdRhFlatnesses.SingleOrDefault(x => x.RhId == id);
                    if (itemRH != null && itemReadhead != null && itemRhFlatness != null)
                    {
                        _contextDbEtdFac3.EtdRhDetails.Remove(itemRH);
                        _contextDbEtdFac3.EtdRearHeads.Remove(itemReadhead);
                        _contextDbEtdFac3.EtdRhFlatnesses.Remove(itemRhFlatness);
                        await _contextDbEtdFac3.SaveChangesAsync();
                    }
                    break;
                case "cs":
                    var itemCSECC = _contextDbEtdFac3.EtdCsEccs.SingleOrDefault(x => x.CsId == id);
                    if (itemCSECC != null)
                    {
                        _contextDbEtdFac3.EtdCsEccs.Remove(itemCSECC);
                    }
                    var itemEtdOdFr = _contextDbEtdFac3.EtdCsOdFrs.SingleOrDefault(x => x.CsId == id);
                    if (itemEtdOdFr != null)
                    {
                        _contextDbEtdFac3.EtdCsOdFrs.Remove(itemEtdOdFr);
                    }
                    var itemEtdOdPin = _contextDbEtdFac3.EtdCsOdPins.SingleOrDefault(x => x.CsId == id);
                    if (itemEtdOdPin != null)
                    {
                        _contextDbEtdFac3.EtdCsOdPins.Remove(itemEtdOdPin);
                    }
                    var cs = _contextDbEtdFac3.EtdCrankShafts.SingleOrDefault(x => x.CsId == id);
                    if (cs != null)
                    {
                        _contextDbEtdFac3.EtdCrankShafts.Remove(cs);
                    }
                    await _contextDbEtdFac3.SaveChangesAsync();
                    break;
                case "cy":
                    var itemBore = _contextDbEtdFac3.EtdCyIdBores.SingleOrDefault(x => x.CyId == id);
                    if (itemBore != null)
                    {
                        _contextDbEtdFac3.EtdCyIdBores.Remove(itemBore);
                    }
                    var itemBush = _contextDbEtdFac3.EtdCyIdBushes.SingleOrDefault(x => x.CyId == id);
                    if (itemBush != null)
                    {
                        _contextDbEtdFac3.EtdCyIdBushes.Remove(itemBush);
                    }
                    var itemHeight = _contextDbEtdFac3.EtdCyHeights.SingleOrDefault(x => x.CyId == id);
                    if (itemHeight != null)
                    {
                        _contextDbEtdFac3.EtdCyHeights.Remove(itemHeight);
                    }

                    var itemCy = _contextDbEtdFac3.EtdCylinders.SingleOrDefault(x => x.CyId == id);
                    if (itemCy != null)
                    {
                        _contextDbEtdFac3.EtdCylinders.Remove(itemCy);
                    }
                    await _contextDbEtdFac3.SaveChangesAsync();
                    return Ok("cy");
                case "pt":
                    var itemOd = _contextDbEtdFac3.EtdPtOds.SingleOrDefault(x => x.PtId == id);
                    if (itemOd != null)
                    {
                        _contextDbEtdFac3.EtdPtOds.Remove(itemOd);
                    }
                    var itemId = _contextDbEtdFac3.EtdPtIds.SingleOrDefault(x => x.PtId == id);
                    if (itemId != null)
                    {
                        _contextDbEtdFac3.EtdPtIds.Remove(itemId);
                    }
                    var itemHeigth = _contextDbEtdFac3.EtdPtHeights.SingleOrDefault(x => x.PtId == id);
                    if (itemHeigth != null)
                    {
                        _contextDbEtdFac3.EtdPtHeights.Remove(itemHeigth);
                    }

                    var itemFlatNess = _contextDbEtdFac3.EtdPtFlatnesses.SingleOrDefault(x => x.PtId == id);
                    if (itemFlatNess != null)
                    {
                        _contextDbEtdFac3.EtdPtFlatnesses.Remove(itemFlatNess);
                    }

                    var itemPtBlade = _contextDbEtdFac3.EtdPtBlades.SingleOrDefault(x => x.PtId == id);
                    if (itemPtBlade != null)
                    {
                        _contextDbEtdFac3.EtdPtBlades.Remove(itemPtBlade);
                    }


                    var pt = _contextDbEtdFac3.EtdPistons.SingleOrDefault(x => x.PtId == id);
                    if (pt != null)
                    {
                        _contextDbEtdFac3.EtdPistons.Remove(pt);
                    }
                    await _contextDbEtdFac3.SaveChangesAsync();
                    return Ok("pt");
                default:
                    return Ok("default");
            }
            return Ok();
        }



        [HttpPost]
        [Route("/pt/add")]
        public async Task<IActionResult> Piston([FromBody] PistonDataSet props)
        {
            EtdPtId itemId = new EtdPtId();
            itemId.PtId = props.PtId;
            itemId.PtIdRank = Convert.ToDouble(props.PtIdRank);
            itemId.PtIdRankC = "A";
            itemId.PtIdRoundness = Convert.ToDouble(props.PtIdRoundness);
            itemId.PtIdCylindricity = Convert.ToDouble(props.PtIdCylindricity);
            itemId.PtIdPerpendicularity = Convert.ToDouble(props.PtIdPerpendicularity);
            itemId.PtIdJudgement = "OK";
            itemId.PtIdConcentricity = Convert.ToDouble(props.PtIdConcentricity);
            itemId.PtIdDate = DateTime.Now;
            _contextDbEtdFac3.EtdPtIds.Add(itemId);

            EtdPtOd itemOd = new EtdPtOd();
            itemOd.PtId = props.PtId;
            itemOd.PtOdRank = Convert.ToDouble(props.PtOdRank);
            itemOd.PtOdRankC = "A";
            itemOd.PtOdJudgeRoundness = Convert.ToDouble(props.PtOdJudgeRoundness);
            itemOd.PtOdCylindricity = Convert.ToDouble(props.PtOdCylindricity);
            itemOd.PtOdJudgement = "OK";
            itemOd.PtOdPerpendicularity = Convert.ToDouble(props.PtOdPerpendicularity);
            itemOd.PtOdDate = DateTime.Now;
            _contextDbEtdFac3.EtdPtOds.Add(itemOd);

            EtdPtBlade itemBlade = new EtdPtBlade();
            itemBlade.PtId = props.PtId;
            itemBlade.PtBlRankC = "A";
            itemBlade.PtBlRank = Convert.ToDouble(props.PtBlRank);
            itemBlade.PtBlParallism = Convert.ToDouble(props.PtBlParallism);
            itemBlade.PtBlPerpendicularity = 0;
            itemBlade.PtBlJudgement = "OK";
            itemBlade.PtBlDate = DateTime.Now;
            _contextDbEtdFac3.EtdPtBlades.Add(itemBlade);

            EtdPtHeight itemHeight = new EtdPtHeight();
            itemHeight.PtId = props.PtId;
            itemHeight.PtHeRankC = "A";
            itemHeight.PtHeRank = Convert.ToDouble(props.PtHeRank);
            itemHeight.PtHeParallism = Convert.ToDouble(props.PtHeParallism);
            itemHeight.PtHeDate = DateTime.Now;
            itemHeight.PtHeJudgement = "OK";
            _contextDbEtdFac3.EtdPtHeights.Add(itemHeight);


            EtdPiston itemPiston = new EtdPiston();
            itemPiston.PtId = props.PtId;
            itemPiston.ProId = "19";
            itemPiston.MId = props.Mid;
            itemPiston.PtPosition = 0;
            itemPiston.PtJudgement = "OK";
            itemPiston.PtLine = "PT_HEI_FAC3";
            itemPiston.PtDate = DateTime.Now;
            itemPiston.FirstStamptime = DateTime.Now;
            _contextDbEtdFac3.EtdPistons.Add(itemPiston);

            var insertEcc = await _contextDbEtdFac3.SaveChangesAsync();

            if (insertEcc > 0)
            {
                return Ok(new { status = true });
            }
            else
            {
                return Ok(new { status = false });
            }
        }



        [HttpPost]
        [Route("/qcstd/getall")]
        public async Task<IActionResult> qcstdGetAll([FromBody] ModelManual props)
        {
            DateTime dStart = DateTime.Parse("2023-01-01");
            if (props.type == "fh")
            {
                return Ok(_contextDbEtdFac3.EtdFhDetails.Where(x => x.FhId.StartsWith("00") && x.FhDate >= dStart).OrderByDescending(x => x.FhDate).ToList());
            }
            else if (props.type == "rh")
            {
                return Ok(_contextDbEtdFac3.EtdRhDetails.Where(x => x.RhId.StartsWith("00") && x.RhDate >= dStart).OrderByDescending(x => x.RhDate).ToList());
            }
            else if (props.type == "cs")
            {
                return Ok(_contextDbEtdFac3.EtdCsOdFrs.Where(x => x.CsId.StartsWith("00") && x.CsFrDate >= dStart).OrderByDescending(x => x.CsFrDate).ToList());
            }
            else if (props.type == "cy")
            {
                return Ok(_contextDbEtdFac3.EtdCyIdBushes.Where(x => x.CyId.StartsWith("00") && x.CyBuDate >= dStart).OrderByDescending(x => x.CyBuDate).ToList());
            }
            else if (props.type == "pt")
            {
                return Ok(_contextDbEtdFac3.EtdPtIds.Where(x => x.PtId.StartsWith("00") && x.PtIdDate >= dStart).OrderByDescending(x => x.PtIdDate).ToList());
            }
            return Ok();
        }

        [HttpPost]
        [Route("/graphql")]
        public async Task<IActionResult> getAllGraphQL()
        {

            return Ok();
        }

        [HttpGet]
        [Route("/model")]
        public async Task<IActionResult> getModel()
        {
            var context = _contextDbEtdFac3.EtdMstModels.OrderByDescending(x => x.MName).ToList();
            var result = from item in context
                         select new
                         {
                             label = item.MName,
                             code = item.MId
                         };
            return Ok(result);
        }

        [HttpPost]
        [Route("/update/fh")]
        public async Task<IActionResult> UpdateQcMaster([FromBody] FrontHeadDataSet props)
        {
            try
            {
                var detail = await _contextDbEtdFac3.EtdFhDetails.FirstOrDefaultAsync(x => x.FhId == props.FhId);
                if (detail != null)
                {
                    detail.FhRank = props.FhRank;
                    detail.FhPerpendicularity = props.FhPerpendicularity;
                    detail.FhConcentricity = props.FhConcentricity;
                    detail.FhJudgeRoundness = props.FhJudgeRoundness;
                    detail.FhCylindricity = props.FhCylindricity;
                }
                var fh = await _contextDbEtdFac3.EtdFrontHeads.FirstOrDefaultAsync(x => x.FhId == props.FhId);
                if (fh != null)
                {
                    fh.MId = props.Mid;
                }
                await _contextDbEtdFac3.SaveChangesAsync();
                return Ok(new { status = true });
            }
            catch(Exception e)
            {
                return Ok(new { status = false,message = e.Message });
            }
           
        }

        [HttpPost]
        [Route("/update/rh")]
        public async Task<IActionResult> UpdateRearHead([FromBody] ReadHeaderDataSet props)
        {
            try
            {
                var detail = await _contextDbEtdFac3.EtdRhDetails.FirstOrDefaultAsync(x => x.RhId == props.RhId);
                if (detail != null)
                {
                    detail.RhRank = props.RhRank;
                    detail.RhJudgeRoundness = props.RhJudgeRoundness;
                    detail.RhCylindricity = props.RhCylindricity;
                    detail.RhPerpendicularity = props.RhPerpendicularity;
                }
                var rs = await _contextDbEtdFac3.EtdRearHeads.FirstOrDefaultAsync(x => x.RhId == props.RhId);
                if (rs != null)
                {
                    rs.MId = props.Mid;
                }
                int update = await _contextDbEtdFac3.SaveChangesAsync();
                return Ok(new { status = true });
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message });
            }
        }

        [HttpPost]
        [Route("/update/cs")]
        public async Task<IActionResult> UpdateCrankShaft([FromBody] ChankShaftDataSet props)
        {

            try
            {
                var detail = await _contextDbEtdFac3.EtdCsOdFrs.FirstOrDefaultAsync(x => x.CsId == props.CsId);
                if (detail != null)
                {
                    detail.CsFrFRank = Convert.ToDouble(props.CsFrFRank);
                    detail.CsFrRRank = Convert.ToDouble(props.CsFrRRank);
                    detail.CsFrFJudgeRoundness = Convert.ToDouble(props.CsFrFJudgeRoundness);
                    detail.CsFrRJudgeRoundness = Convert.ToDouble(props.CsFrRJudgeRoundness);
                    detail.CsFrFCylindricity = Convert.ToDouble(props.CsFrFCylindricity);
                    detail.CsFrRCylindricity = Convert.ToDouble(props.CsFrRCylindricity);
                }
                var cs = await _contextDbEtdFac3.EtdCrankShafts.FirstOrDefaultAsync(x => x.CsId == props.CsId);
                if (cs != null)
                {
                    cs.MId = props.Mid;
                }
                var CSPIN = await _contextDbEtdFac3.EtdCsOdPins.FirstOrDefaultAsync(x => x.CsId == props.CsId);
                if (CSPIN != null)
                {
                    CSPIN.CsPinRank = Convert.ToDouble(props.CsPinRank);
                    CSPIN.CsPinJudgeRoundness = Convert.ToDouble(props.CsPinJudgeRoundness);
                    CSPIN.CsPinCylindricity = Convert.ToDouble(props.CsPinCylindricity);
                }
                var CSECC = await _contextDbEtdFac3.EtdCsEccs.FirstOrDefaultAsync(x => x.CsId == props.CsId);
                if (CSECC != null)
                {
                    CSECC.CsEccRank = Convert.ToDouble(props.CsEccRank);
                }
                await _contextDbEtdFac3.SaveChangesAsync();
                return Ok(new { status = true });
            }
            catch (Exception e)
            {
                return Ok(new { status = false, message = e.Message });
            }
        }


        [HttpPost]
        [Route("/update/cy")]
        public async Task<IActionResult> UpdateCylinder([FromBody] CylinderDataSet props)
        {
            try
            {
                var cyBush = await _contextDbEtdFac3.EtdCyIdBushes.FirstOrDefaultAsync(x => x.CyId == props.CyId);
                if (cyBush != null)
                {
                    cyBush.CyBuRank = Convert.ToDouble(props.CyBuRank);
                    cyBush.CyBuJudgeRoundness = Convert.ToDouble(props.CyBuJudgeRoundness);
                    cyBush.CyBuPerpendicularity = Convert.ToDouble(props.CyBuPerpendicularity);
                    cyBush.CyBuCylindricity = Convert.ToDouble(props.CyBuCylindricity);
                }
                var cyBore = await _contextDbEtdFac3.EtdCyIdBores.FirstOrDefaultAsync(x => x.CyId == props.CyId);
                if (cyBore != null)
                {
                    cyBore.CyBoRank = Convert.ToDouble(props.CyBoRank);
                    cyBore.CyBoJudgeRoundness = Convert.ToDouble(props.CyBoJudgeRoundness);
                    cyBore.CyBoCylindricity = Convert.ToDouble(props.CyBoCylindricity);
                    cyBore.CyBoConcentricity = Convert.ToDouble(props.CyBoConcentricity);
                    cyBore.CyBoPerpendicularity = Convert.ToDouble(props.CyBoPerpendicularity);
                }
                var cyHeight = await _contextDbEtdFac3.EtdCyHeights.FirstOrDefaultAsync(x => x.CyId == props.CyId);
                if (cyHeight != null)
                {
                    cyHeight.CyHeRank = Convert.ToDouble(props.CyHeRank);
                    cyHeight.CyHeParallism = Convert.ToDouble(props.CyHeParallism);
                }
                var cylinder = await _contextDbEtdFac3.EtdCylinders.FirstOrDefaultAsync(x => x.CyId == props.CyId);
                if (cylinder != null)
                {
                    cylinder.MId = props.Mid;
                }
                await _contextDbEtdFac3.SaveChangesAsync();
                return Ok(new { status = true });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }

        [HttpPost]
        [Route("/update/pt")]
        public async Task<IActionResult> UpdatePiston([FromBody] PistonDataSet props)
        {
            try
            {
                var itemId = _contextDbEtdFac3.EtdPtIds.SingleOrDefault(x => x.PtId == props.PtId);
                if (itemId != null)
                {
                    itemId.PtIdRank = Convert.ToDouble(props.PtIdRank);
                    itemId.PtIdRoundness = Convert.ToDouble(props.PtIdRoundness);
                    itemId.PtIdCylindricity = Convert.ToDouble(props.PtIdCylindricity);
                    itemId.PtIdPerpendicularity = Convert.ToDouble(props.PtIdPerpendicularity);
                    itemId.PtIdPerpendicularity = Convert.ToDouble(props.PtIdPerpendicularity);
                }
                var itemOd = _contextDbEtdFac3.EtdPtOds.SingleOrDefault(x => x.PtId == props.PtId);
                if (itemOd != null)
                {
                    itemOd.PtOdRank = Convert.ToDouble(props.PtOdRank);
                    itemOd.PtOdJudgeRoundness = Convert.ToDouble(props.PtOdJudgeRoundness);
                    itemOd.PtOdCylindricity = Convert.ToDouble(props.PtOdCylindricity);
                    itemOd.PtOdPerpendicularity = Convert.ToDouble(props.PtOdPerpendicularity);
                }
                var itemHeigth = _contextDbEtdFac3.EtdPtHeights.SingleOrDefault(x => x.PtId == props.PtId);
                if (itemHeigth != null)
                {
                    itemHeigth.PtHeRank = Convert.ToDouble(props.PtHeRank);
                    itemHeigth.PtHeParallism = Convert.ToDouble(props.PtHeParallism);
                }
                var itemPtBlade = _contextDbEtdFac3.EtdPtBlades.SingleOrDefault(x => x.PtId == props.PtId);
                if (itemPtBlade != null)
                {
                    itemPtBlade.PtBlRank = Convert.ToDouble(props.PtBlRank);
                    itemPtBlade.PtBlParallism = Convert.ToDouble(props.PtBlParallism);
                }
                var piston = _contextDbEtdFac3.EtdPistons.SingleOrDefault(x => x.PtId == props.PtId);
                if (piston != null)
                {
                    piston.MId = props.Mid;
                }
                await _contextDbEtdFac3.SaveChangesAsync();
                return Ok(new { status = true });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false,message=ex.Message });
            }
        }
    }
}
